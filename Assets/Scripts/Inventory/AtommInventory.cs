using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtommInventory : MonoBehaviour
{
	public AudioSource audioSource;
	public AudioClip itemPickUp;

	private bool canCollect;

	List<Slot> inventory;

	Dictionary <int, bool> ownedFragments;

	Transform documents, items, docView, canvas, containerItems, containerDocs, canvasContainer;
	GameObject inv, itemSlot, documentSlot, docViewer, container, erit, erdoc, fx;
	PlayerController pm;
	PlayerController pl;
	CanvasScaler cs;

	private void Start()
	{
		inventory = new List<Slot>();

		ownedFragments = new Dictionary<int, bool>();

		ownedFragments.Add(0, true);
		ownedFragments.Add(1, false);
		ownedFragments.Add(2, false);
		ownedFragments.Add(3, false);
		ownedFragments.Add(5, false);
		ownedFragments.Add(8, false);

		canvas = GameObject.Find("Canvas").transform;
		inv = Instantiate(Resources.Load<GameObject>("Core/AIS/AtommInventory"), canvas);

		items = inv.transform.Find("Items");
		itemSlot = Resources.Load<GameObject>("Core/AIS/AtommSlot");

		docViewer = Resources.Load<GameObject>("Core/AIS/AtommViewer");
		container = Resources.Load<GameObject>("Core/AIS/AtommContainer");
		erit = Resources.Load<GameObject>("Core/AIS/ERIT");
		erdoc = Resources.Load<GameObject>("Core/AIS/ERDOC");
		fx = Resources.Load<GameObject>("Core/AIS/_FX");
		inv.SetActive(false);
		cs = canvas.GetComponent<CanvasScaler>();
		cs.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		cs.referenceResolution = new Vector2(1280, 720);
		cs.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
		cs.matchWidthOrHeight = 0.5f;
	}

	public void CheckRaycast()
	{
		Transform playerCamera;
		gameObject.layer = LayerMask.NameToLayer(LayerMask.LayerToName(2));

		RaycastHit hit;
		playerCamera = Camera.main.transform;

		Vector3 forward = transform.TransformDirection(Vector3.forward) * 100;

		if (Physics.Raycast(playerCamera.position, forward, out hit, 250f))
		{
			if (hit.collider.GetComponent<AtommItem>() != null  ) 
			{
				if (CanCollectItem( hit.collider.GetComponent<AtommItem>() ))
				{
					if (!inv.activeSelf)
					{
						ownedFragments[hit.collider.GetComponent<AtommItem>().fragmentNumber] = true;
						GatherItem(hit.collider.GetComponent<AtommItem>());
						audioSource.PlayOneShot(itemPickUp);
						canvas.Find("ErrorMessages").GetComponent<Text>().text = "You collected fragment " + hit.collider.GetComponent<AtommItem>().fragmentNumber;
						// canvas.Find("Instructions").GetComponent<Text>().text = "You collected fragment " + hit.collider.GetComponent<AtommItem>().fragmentNumber;
					}
				}
				else 
				{
					canvas.Find("ErrorMessages").GetComponent<Text>().text = "Collect the Previous fragments first";
				}
			}
			else if (hit.collider.GetComponent<AtommContainer>() != null)
			{
				if (!inv.activeSelf)
				{
					ContainerActive(hit.collider.GetComponent<AtommContainer>());
				}
			}
		}
		gameObject.layer = LayerMask.NameToLayer(LayerMask.LayerToName(0));
		Refresh();

		return;
	}

	public bool CanCollectItem (AtommItem atommItem)
	{
		canCollect = true;

		foreach (KeyValuePair<int, bool> fragment in ownedFragments) 
		{
			if (atommItem.fragmentNumber == fragment.Key)
			{
				return canCollect;
			}
			if (!ownedFragments[fragment.Key])
			{
				canCollect = false;
				return canCollect;
			}
		}
		return canCollect;
	}

	public void ContainerActive (AtommContainer atommC)
	{
		ActionInventory();

		GameObject cont = Instantiate(container, canvas);
		canvasContainer = cont.transform;
		containerItems = cont.transform.Find("_I");
		containerDocs = cont.transform.Find("_D");

		foreach(Slot slot in atommC.slots)
		{
			GameObject button = Instantiate(itemSlot, containerItems);
			if (slot.quantity != 1)
			{
				button.transform.Find("Text").GetComponent<Text>().text = slot.quantity.ToString("");
			}
			else
			{
				button.transform.Find("Text").GetComponent<Text>().text = "";
			}
			button.transform.Find("Image").GetComponent<Image>().sprite = slot.icon;
			button.GetComponent<Button>().onClick.AddListener(delegate { GatherItem(slot, atommC); });
		}
	}

	public void ActionInventory()
	{
		if (docView != null)
		{
			Destroy(docView.gameObject);
		}

		if (canvasContainer != null)
		{
			Destroy(canvasContainer.gameObject);
		}

		inv.SetActive(!inv.activeSelf);
		if (pm != null && pl != null)
		{ 
			pm.enabled = !pm.enabled; pl.enabled = !pl.enabled; 
		}
		Refresh();

		if (!inv.activeSelf)
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	public void Freeze(bool o)
	{
		if (pm != null && pl != null)
		{ 
			pm.enabled = !o; pl.enabled = !o; 
		}
		Refresh();

		if (!o)
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
		else
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}
	}

	private void GatherItem(AtommItem item)
	{
		if (inventory.Count == 24)
		{
			return;
		}
		inventory.Add(new Slot(item));
		Destroy(item.gameObject);
	}

	private void GatherItem(Slot item, AtommContainer atommC)
	{
		if (inventory.Count == 24)
		{
			return;
		}
		inventory.Add(item);
		atommC.slots.Remove(item);
		Refresh();
		RefreshContainer(atommC);
	}

	void RefreshContainer (AtommContainer atommC)
	{
		foreach (Transform child in containerItems)
		{
			Destroy(child.gameObject);
		}

		foreach (Transform child in containerDocs)
		{
			Destroy(child.gameObject);
		}

		foreach (Slot slot in atommC.slots)
		{
			GameObject button = Instantiate(itemSlot, containerItems);
			if (slot.quantity != 1)
					button.transform.Find("Text").GetComponent<Text>().text = slot.quantity.ToString("");
			else
					button.transform.Find("Text").GetComponent<Text>().text = "";
			button.transform.Find("Image").GetComponent<Image>().sprite = slot.icon;
			button.GetComponent<Button>().onClick.AddListener(delegate { GatherItem(slot, atommC); });
		}
	}

	private void Refresh()
	{
		foreach (Transform child in items)
		{
			Destroy(child.gameObject);
		}

		foreach (Slot slot in inventory)
		{
			GameObject button = Instantiate(itemSlot, items);
			if (slot.quantity != 1)
			{
				button.transform.Find("Text").GetComponent<Text>().text = slot.quantity.ToString("");
			}
			else
			{
				button.transform.Find("Text").GetComponent<Text>().text = "";
			}
			button.transform.Find("Image").GetComponent<Image>().sprite = slot.icon;
		}
	}

	private void Action(Slot slot)
	{
		if (Resources.Load<GameObject>("Prefabs/" + slot.itemName) == null)
		{
			GameObject newItem = Instantiate(erit, transform.position, transform.rotation);
			newItem.GetComponent<AtommItem>().itemName = slot.itemName;
			newItem.GetComponent<AtommItem>().quantity = slot.quantity;
		}
		else
		{
			GameObject newItem = Instantiate(Resources.Load<GameObject>("Prefabs/" + slot.itemName), transform.position, transform.rotation);
			newItem.GetComponent<AtommItem>().itemName = slot.itemName;
			newItem.GetComponent<AtommItem>().quantity = slot.quantity;
		}
		inventory.Remove(slot);
		Refresh();
	}

	public bool LookFor(string item)
	{
		foreach (Slot slot in inventory)
			if (slot.itemName == item)
				return true;

		return false;
	}

	public bool LookFor(string item, int quantity)
	{
		foreach (Slot slot in inventory)
			if (slot.itemName == item)
			{
				return true;
			}

		return false;
	}

	public bool LookForAndRemove(string item)
	{
		foreach (Slot slot in inventory)
			if (slot.itemName == item)
			{ 
				inventory.Remove(slot); return true; 
			}

		return false;
	}

	public bool LookForAndRemove(string item, int quantity)
	{
		foreach (Slot slot in inventory)
		{
			if (slot.itemName == item && slot.quantity >= quantity)
			{
				slot.quantity -= quantity;
				if (slot.quantity <= 0)
				{
					inventory.Remove(slot);
				}
				return true;
			}
		}
		return false;
	}

	[System.Serializable]
	public class Slot
	{
		public string itemName;
		public int quantity;
		public Sprite icon;

		public Slot(AtommItem item)
		{
			this.itemName = item.itemName;
			this.quantity = item.quantity;
			this.icon = item.icon;
		}
	}

	[System.Serializable]
	public class Document
	{
		public string documentName;
		[TextArea(5, 10)]
		public string documentText;

		public Document(AtommDocument doc)
		{
			this.documentName = doc.documentName;
			this.documentText = doc.documentText;
		}
	}
}
