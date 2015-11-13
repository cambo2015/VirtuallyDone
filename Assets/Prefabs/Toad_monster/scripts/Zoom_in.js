#pragma strict
var zoom : int = 22;
var normal : int = 40;
var smooth : float = 5;
private var isZoomed = false;
function Update () {
     if(Input.GetMouseButtonDown(1)){
          isZoomed = !isZoomed; 
     }
 
     if(isZoomed == true){
          camera.fieldOfView = Mathf.Lerp(camera.fieldOfView,zoom,Time.deltaTime*smooth);
     }
     else{
        camera.fieldOfView = Mathf.Lerp(camera.fieldOfView,normal,Time.deltaTime*smooth);
     }
}