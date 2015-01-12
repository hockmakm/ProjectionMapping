#pragma strict
var ob:float = 0.08f;

function SetObliqueness(horizObl: float, vertObl: float) {
    var mat: Matrix4x4 = camera.projectionMatrix;
    mat[0, 2] = horizObl;
    mat[1, 2] = vertObl;
    camera.projectionMatrix = mat;
}

function Start () {
	SetObliqueness(0.0f,ob);
}