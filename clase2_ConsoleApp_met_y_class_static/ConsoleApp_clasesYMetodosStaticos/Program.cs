namespace ConsoleApp_clasesYMetodosStaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodos Y Class estaticas");

            /*
             -Principio Dry       -----------         The Pragmatic Programmer - Dave Thomas
            "Toda pieza de conocimiento debe tener una representación única, 
            inequívoca y fidedigna dentro de un sistema."

            PIEZA DE CONOCIMIENTO - Funcionalidad precisa dentro del contexto de 
            negocio o un algoritmo concreto.

            UNICA - no debe de existir otra representacion

            INEQUIVOCA - Sólo puede ser interpretada, entendida o explicada de una manera


            FIDEDIGNA - Conamos en que es correcta

             ---------------------------------------------------------------------------------
             ----------- METODOS ESTATICOS

             
            public static double SoyElNombreDelMetodo(int numero)
            {


            }
             
             
            MODIFICADOR DE ACCESO ejemplo: public  ----- accesible de cualquier parte

            METODOS DE EXTENCION * ejemplo static ------- no necesitan ser instanciados y se 
            pueden usar llamando de esta forma por ejemplo : a la ClassHora.VerHora()

            METODOS DE INSTANCIA - ejemplo public int CalcularEdad()         -no tiene el static


            TIPO DE DATO - double                  otros: INT, float, string

            NOMBRE DEL METODO  - se escribe eb UpperCalem Case

            PARAMETROS - (string soyUnParametro)       son valores que se pasan a una función o 
            método cuando se llama. Estos valores pueden ser utilizados dentro de la función 
            para realizar cálculos o llevar a cabo acciones específicas.




            ----------------------------------------------------------------------------------
            MODIFICADORES DE ACCESO :
            public : accesible de cualquier parte
            private: solo accesible dentro del mismo tipo
            internal: solo accesible dentro del mismo ensanblado / proyecto
            protected. solo accesible dentro del mismo tipo y tipo derivado (hijos) mediante herencia
            ----------------------------------------------------------------------------------


            -------------------------------- BUENAS PRACTICAS --------------------------------

            LOS NOMBRES IMPORTAN :Nombres descriptivos, se prefiere legibilidad a un nombre breve
            que no represente la accion.

            HACER UNA COSA:Debe hacer una cosa, hacerlo bien y ser lo unico que haga.

            RAMAÑO REDUCIDO: 20 lineas como mucho

            ANIDAMIENTO: maximo 2 niveles de anidamiento


            ---------- REGLAS DE CLEAN CODE:
            Reglas del boyscout : dejar el campamanto mas limpio de lo encontrado

            Autor del codigo : “El código limpio se lee como prosa bien escrita” funciones 
            simples, claras y pequeñas

            Dry : No pueden existir dos partes del programa que realicen la misma función.

            Los comentarios mienten: los codigos son modificados, los comentarios no. 
            comentar lo necesario

            Los nombres importan: deben ser presisos y entregar la idea central

            ---------- REFACTORIZAR
            “Escribir software es como cualquier otro tipo de escritura. Cuando escribes 
            un ensayo o un artículo, primero estructuras las ideas y después 
            el mensaje hasta que se lee bien. El primer borrador puede ser torpe y 
            desorganizado, así que lo retocas y mejoras hasta que se lea de la forma 
            adecuada...


            --------- DOCUMENTACION XML
            parandose arriba del metodo escribit /// y te arma la estructura xml para la 
            documentacion, Sirve para aclarar en simples palabras que hace el metodo, que 
            recibe y que devuelve, entre otras cosas.

            ----------------------------------NAMESPACE---------------------------------------
            Son una agrupación lógica de clases y otros elementos del código fuente.
            Todo lo que declaremos deberá estar contenido dentro de un espacio de nombres.
            Su función principal es la organización del código, permitiendo la reducción de 
            conictos por nombres duplicados y la posibilidad de trabajar en un mismo programa 
            con componentes de distinta procedencia.






            ---------------------------------DIRECTIVA USING ---------------------------------
            La directiva using permite la especicación de una llamada a un método sin el uso 
            obligatorio de un nombre completamente cualificado (nombre completo incluyendo el espacio
            de nombres)

            osea si no usaramos la directiva using (es como una importacion algo parecido al import de python)
            tendriamos que pomer:
            ConsoleApp_clasesYMetodosStaticos.SoyUnMetodoDeEseNameSpace();


            por otra parte si usaramos la directiva usin seria asi:
            using ConsoleApp_clasesYMetodosStaticos;

            // Ahora puedes usar el método sin especificar el nombre completo
            SoyUnMetodoDeEseNameSpace();

            -----------DIRECTIVA ALIAS
            Permite usar una directiva con un alias por ejemplo.
            using CS = System.Console; //directiva Alias

            public class Program
            {
                public static void Main()
            {
                    CS.WriteLine("Hola Mundo");    // ase puede reemplzar porel alias

            }


            }





       
        ----- StringBuilder ------- 
            Append  : Agrega información al nal del StringBuilder actual
            AppendLine . Agrega información al nal del StringBuilder actual con un salto de línea
            AppendFormat: Reemplaza el formato pasado en un string con texto formateado.
            Insert: Inserta un string en el índice especificado del StringBuilder actual .

        -----Math ---- no hay nada aun de esto....



        Ver PDF

             
            


        }
    }
}