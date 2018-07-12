Zara.Reto0 utiliza patron de 3 capas.
1. Presentation, donde he creado la aplicaci�n de consola.
2. Common, donde est� el modelo CotizationDay.cs y la carpeta Utils, donde hay 2 clases separadas siguiendo el principio Single Responsability.
3. Infrastructure, donde guardo separados los Contracts, 1 en este caso, y CotizationDayRepository.

PRESENTATION
En la aplicaci�n de consola, saldr�n unos "chivatos" puestos en el c�digo para ver en todo momento por donde pasa la aplicaci�n, que calculos realiza y cuanto valen las variables importantes.

COMMON
El modelo CotizationDay, es mi interpretaci�n abstracta personal del ejercicio y como yo lo veo m�s f�cil de tratar.
CotizationDay tiene 3 atributos: fecha, apertura y cierre, que son los campos que nos har�n falta del .csv.

UTILS
Crearemos 2 utilidades est�ticas separadas, ya que no tienen nada que ver una con la otra, y as� poderlas usar en un futuro si fuera necesario.
FileManager, le das una ruta terminada en un fichero .csv, y te devuelve una List<string> por cada l�nea.
DateTimeUtil te devuelve el �ltimo Jueves del mes de la fecha que le env�es. Ser�a �ptimo modificarlo para un futuro, para pasarle un d�a de la semana concreto y que te devolviese ese �ltimo d�a de la semana del mes deseado.

INFRASTRUCTURE
La interfaz ICotizationDayRepository, siguiendo el principio Interface Segregation, viene bien crearla con los m�todos necesarios para un futuro por si se a�aden m�s Repositorios.
La clase CotizationDayRepository, es la encargada de gestionar las funcionalidades del Modelo.
Tiene 3 atributos. El path para el fichero .csv que cargaremos, la Lista de strings que devolver� dicho fichero, y la List<CotizationDay> final que crearemos apartir de la lista de strings previa.
	--FUNCIONES
	.Generarlistado(): Llama al m�todo est�tico FileManager.OpenCSV(Path) y devuelve la Lista de strings.
	Con esta lista, generamos la Lista de CotizationDay separando por cada columna y creando un objeto del Modelo por l�nea.
	La primera l�nea del csv no la leemos, porque es el t�tulo de cada columna. Pero ser�a adecuado poder detectar si los par�metros le�dos no son los que buscamos y saltarnoslos si no los necesitamos, en lugar de ignorar la primera l�nea.
	Por una cuesti�n de tiempo, esta, entre otras cosas, se dejaron as�.
	
	.Ganancia(): Le pasamos la retenci�n del Broker, la inversi�n inicial y la fecha de venta de las acciones, para poder calcular en un futuro el beneficio con otros par�metros.
	Algunas funciones de Lista, como Lista<T>.Exists(T) entre otras, no he podido usarlas por darme errores que no comprend�a todav�a y no he sabido resolver.
	Sin embargo, me he buscado la vida para hacerlo de forma manual y poder sacar el ejercicio adelante. Consumir� m�s recursos, pero es funcional.
	Hacemos un foreach por cada fecha en la Lista y entramos a la funcionalidad solamente si el mes es distinto al del anterior vuelta para hacer esta operaci�n una vez por mes. 
	Buscamos el �ltimo jueves del mes de cada fecha, y le sumamos uno.
	Buscamos dicha fecha en el listado fechas de CotizationDays. Si no existe, le sumamos uno. 
	Y as� respectivamente hasta encontrar "El siguiente d�a cotizado despu�s de cobrar el �ltimo jueves de cada mes".
	Al encontrarlo, guardamos esa fecha en un Nuevo listado de d�as de compra operativos. 
	Cuando tenemos la Lista con los d�as cotizados de compra, dividimos el dinero de la inversi�n inicial por la retenci�n del broker y obtenemos la inversi�n final.
	Finalmente, calculamos las acciones que vamos comprando al precio de apertura de ese d�a, y vamos sum�ndolo al n�mero final de acciones.
	Y para terminar, multiplicamos las acciones totales al precio de cierre del d�a de venta indicado.

	.UltimoDiaFichero(): Nos dice la fecha del �ltimo d�a que figura en un listado de d�as de cotizaci�n.