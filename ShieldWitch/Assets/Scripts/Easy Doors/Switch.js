var isActivated : boolean = false;
var switchName : String;
var destroyObjectAfterActivation : boolean = false;
var objectToDestroy : GameObject;

function Update(){
   var player = GameObject.FindWithTag("Player");
   var dist = Vector3.Distance(player.transform.position, transform.position);
   
   if(dist < 2 && isActivated == false ){
   
   if(destroyObjectAfterActivation == true){
      Destroy(objectToDestroy);
	  }
	  
      isActivated = true;
	  DoorOpen.switchActivated = switchName;
	  }
}