// The distance variables.
var openDistance : int = 5;
var closeDistance : int = 10;

// The various door states.
var isDown : boolean = true;
var isLocked : boolean = false;
var openOnce : boolean = false;
var openSwitch : boolean = false;
var switchName : String;

var openSound : AudioClip;
var closeSound : AudioClip;

// Used only when openSwitch is true.
// Is also used by the script for the switch.
static var switchActivated : String;

function Update () {
// Find the players location
   var player = GameObject.FindWithTag("Player");
   var dist = Vector3.Distance(player.transform.position, transform.position);
   
   // Opens a starndard door.
   if (dist < openDistance && isDown == true && isLocked == false && openSwitch == false){
	     GetComponent.<Animation>().Play("DoorMoveUp");
		 GetComponent.<AudioSource>().clip = openSound;
		 GetComponent.<AudioSource>().Play();
		 isDown = false;
		 
	// Locks the door after opening if openOnce is true.
	if(openOnce == true){
		isLocked = true;
		}
	}
		
	// Controls the door if openSwitch is true.	
	if(openSwitch == true && switchName == switchActivated){
	   GetComponent.<Animation>().Play("DoorMoveUp");
	   GetComponent.<AudioSource>().clip = openSound;
	   GetComponent.<AudioSource>().Play();
	   switchActivated = "";
	   }
	
	// Closes the door when the player moves away.
	if (dist > closeDistance && isDown == false && openSwitch == false){
	     GetComponent.<Animation>().Play("DoorMoveDown");
		 GetComponent.<AudioSource>().clip = closeSound;
		 GetComponent.<AudioSource>().Play();
		 isDown = true;
		
	}
}

@script RequireComponent(AudioSource)
@script RequireComponent(Animation)