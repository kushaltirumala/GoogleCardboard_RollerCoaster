#pragma strict

private var hit1 : RaycastHit;
private var ray1 : Ray;
 
function FixedUpdate () {
 
    if(Input.touchCount == 1) {
        ray1 = Camera.main.ScreenPointToRay(Input.touches[0].position);
        Debug.DrawLine(ray1.origin,ray1.direction * 10);
        if(Physics.Raycast(ray1.origin, ray1.direction * 10,hit1) && hit1.transform.name =="Coaster"){
          Debug.Log("hit");
           Application.LoadLevel("coaster1");
        }
    }
}