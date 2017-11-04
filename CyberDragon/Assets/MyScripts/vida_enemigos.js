// Sistema de vida para enemigos.

var balas_disparadas = 0;  //Balas disparadas y que le han dado al enemigo.
var balas_necesarias = 5; //Las balas que se necesitan para matar al enemigo.


function OnTriggerEnter( other : Collider ) {
    if (other.tag == "bala")//Si toca el tag "bala". 
    {
        balas_disparadas += 1; //Suma 1 a las balas disparadas.
        Destroy(other.gameObject);//Destruye la bala.
        if (balas_necesarias == balas_disparadas)//Si han tocado al jugador el número de balas necesarias.
        {
            
            Destroy(this.gameObject);//Destruye este objeto.
           
        }
    }
}