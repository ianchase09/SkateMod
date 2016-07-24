#pragma strict

var Camera1: GameObject;
var Camera2: GameObject;
var playerMotor: GameObject;


function Start () {
Camera1.active=true;
Camera2.active=false;


}

function Update () { if (Input.GetKeyDown(KeyCode.F)) { Camera1.active = !Camera1.active; Camera2.active = !Camera2.active; } }