using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
 
public class Gun : MonoBehaviour
{
	public float cooldownSpeed;
	public float fireRate;
	private float accuracy;
	public float maxSpreadAngle;
	public float timeTillMaxSpread;

	public GameObject bullet;
	public GameObject shootPoint;

	public AudioSource audioSource;
	public AudioClip singleShot;
 
	// Start is called before the first frame update
	void Start()
	{
    audioSource = GetComponent<AudioSource>();
		Physics.IgnoreCollision(bullet.GetComponent<Collider>(), shootPoint.GetComponent<Collider>());
	}
 
	// Update is called once per frame
	public void Fire()
	{
		cooldownSpeed += Time.deltaTime * 60f;
		accuracy += Time.deltaTime * 4f;
		if (cooldownSpeed >= fireRate)
		{
			Shoot();
			audioSource.PlayOneShot(singleShot);
			cooldownSpeed = 0;
		}
	}
 
	private void Shoot()
	{
		RaycastHit hit;
		Transform cameraTransform = transform.Find("CameraShip").GetComponent<Camera>().transform;
		Quaternion fireRotation = Quaternion.LookRotation(cameraTransform.forward);

		float currentSpread = Mathf.Lerp(0.0f, maxSpreadAngle, accuracy / timeTillMaxSpread);

		fireRotation = Quaternion.RotateTowards(fireRotation, Random.rotation, Random.Range(0.0f, currentSpread));

		if (Physics.Raycast(transform.position, fireRotation * Vector3.forward, out hit, Mathf.Infinity))
		{
				GameObject tempBullet = Instantiate(bullet, shootPoint.transform.position, fireRotation);
				tempBullet.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
				Physics.IgnoreCollision(tempBullet.GetComponent<Collider>(), shootPoint.GetComponent<Collider>());
				tempBullet.GetComponent<MoveBullet>().hitPoint = hit.point;
		}
	}
}