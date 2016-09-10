#pragma strict

private var hit1 : RaycastHit;
private var ray1 : Ray;
 
function FixedUpdate () {

    if(Input.touchCount == 1) {
        ray1 = Camera.main.ScreenPointToRay(Input.touches[0].position);
        Debug.DrawLine(ray1.origin,ray1.direction * 10);
        if(Physics.Raycast(ray1.origin, ray1.direction * 10,hit1) && hit1.transform.name =="The Beast"){
          Debug.Log("hit");
           Application.LoadLevel("rollercoaster3");
        }
    }
               if(Mathf.Abs (Input.gyro.gravity.x) > .7 && gameObject.Find("Camera_left").GetComponent.<Camera>() == enabled ) {
        ray1 = Camera.main.ScreenPointToRay( Vector2(Screen.width/2,Screen.height/2));
        Debug.DrawLine(ray1.origin,ray1.direction * 10);
          if(Physics.Raycast(ray1.origin, ray1.direction * 100,hit1) && hit1.transform.name =="The Beast"){
          Debug.Log("hit");
           Application.LoadLevel("rollercoaster3");
        }
}
}