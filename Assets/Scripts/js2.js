#pragma strict

private var hit1 : RaycastHit;
private var ray1 : Ray;
 
function FixedUpdate () {
 
    if(Input.touchCount == 1 ) {
        ray1 = Camera.main.ScreenPointToRay(Input.touches[0].position);
        Debug.DrawLine(ray1.origin,ray1.direction * 10);
        if(Physics.Raycast(ray1.origin, ray1.direction * 10,hit1) && hit1.transform.name =="Roller Coaster"){
        Debug.Log(hit1.transform.name);
           Application.LoadLevel("rollercoaster2");
        }
    }
     if(Mathf.Abs (Input.gyro.gravity.x) > .7 && gameObject.Find("Camera_left").tag == "vr" ) {
    ray1 = Camera.main.ScreenPointToRay( Vector3(0,0,0));
        Debug.DrawLine(ray1.origin,ray1.direction * 10);
          if(Physics.Raycast(ray1.origin, ray1.direction * 100,hit1) && hit1.transform.name =="Roller Coaster"){
        Debug.Log(hit1.transform.name);
           Application.LoadLevel("rollercoaster2");
        }
}
}