var projectile : Rigidbody;
var speed = 20; //Velocidad de la bala.
function Update()
{
 if( Input.GetButtonDown( "Fire1" ) )//Si se pulsa el boton izquierdo del ratón.
 {
  var instantiatedProjectile : Rigidbody = Instantiate(
   projectile, transform.position, transform.rotation );
  instantiatedProjectile.velocity =
   transform.TransformDirection( Vector3( 0, 0, speed ) );
  Physics.IgnoreCollision( instantiatedProjectile. GetComponent.<Collider>(),
   transform.root.GetComponent.<Collider>() );
 }
}