#pragma strict
var audio1: AudioSource;
var audio2: AudioSource;
var audio3: AudioSource;

function Start(){

}

// you can then access the different AudioSources using the variables you've set:
function OnTriggerEnter (collision:Collider) {
	
	if(collision.gameObject.name =="Top"){
	audio2.Play();
    audio1.Stop();
  ;
    }
    if(collision.gameObject.name =="Ridestart"){
	audio3.Play();
    audio2.Stop();
 
    }
   
    
    
        if(collision.gameObject.name =="Bottom"){
	audio1.Play();
    audio3.Stop();
   
    }
	}
    