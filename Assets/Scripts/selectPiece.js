#pragma strict

function Start () {

}

function Update () {
    if ( Input.GetMouseButtonDown(0)){
        var hit : RaycastHit;
        var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
        var select = GameObject.FindWithTag("select").transform;
        if (Physics.Raycast (ray, hit, 100.0)){
            select.tag = "none";
            hit.collider.transform.tag = "select";
        }
    }
}