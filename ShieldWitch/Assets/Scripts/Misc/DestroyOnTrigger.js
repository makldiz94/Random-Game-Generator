var triggerName : String;

function Update(){
   if(triggerName == DoorOpen.switchActivated){
      Destroy(gameObject);
	  }
}