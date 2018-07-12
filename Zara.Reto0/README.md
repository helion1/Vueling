Zara.Reto0 utiliza patron de 3 capas.
1. Presentation, donde he creado la aplicación de consola.
2. Common, donde está el modelo CotizationDay.cs y la carpeta Utils, donde hay 2 clases separadas siguiendo el principio Single Responsability.
3. Infrastructure, donde guardo separados los Contracts, 1 en este caso, y CotizationDayRepository.

PRESENTATION
En la aplicación de consola, saldrán unos "chivatos" puestos en el código para ver en todo momento por donde pasa la aplicación, que calculos realiza y cuanto valen las variables importantes.

COMMON
El modelo CotizationDay, es mi interpretación abstracta personal del ejercicio y como yo lo veo más fácil de tratar.
CotizationDay tiene 3 atributos: fecha, apertura y cierre, que son los campos que nos harán falta del .csv.

UTILS
Crearemos 2 utilidades estáticas separadas, ya que no tienen nada que ver una con la otra, y así poderlas usar en un futuro si fuera necesario.
FileManager, le das una ruta terminada en un fichero .csv, y te devuelve una List<string> por cada línea.
DateTimeUtil te devuelve el último Jueves del mes de la fecha que le envíes. Sería óptimo modificarlo para un futuro, para pasarle un día de la semana concreto y que te devolviese ese último día de la semana del mes deseado.

INFRASTRUCTURE
La interfaz ICotizationDayRepository, siguiendo el principio Interface Segregation, viene bien crearla con los métodos necesarios para un futuro por si se añaden más Repositorios.
La clase CotizationDayRepository, es la encargada de gestionar las funcionalidades del Modelo.
Tiene 3 atributos. El path para el fichero .csv que cargaremos, la Lista de strings que devolverá dicho fichero, y la List<CotizationDay> final que crearemos apartir de la lista de strings previa.
	--FUNCIONES
	.Generarlistado(): Llama al método estático FileManager.OpenCSV(Path) y devuelve la Lista de strings.
	Con esta lista, generamos la Lista de CotizationDay separando por cada columna y creando un objeto del Modelo por línea.
	La primera línea del csv no la leemos, porque es el título de cada columna. Pero sería adecuado poder detectar si los parámetros leídos no son los que buscamos y saltarnoslos si no los necesitamos, en lugar de ignorar la primera línea.
	Por una cuestión de tiempo, esta, entre otras cosas, se dejaron así.
	
	.Ganancia(): Le pasamos la retención del Broker, la inversión inicial y la fecha de venta de las acciones, para poder calcular en un futuro el beneficio con otros parámetros.
	Algunas funciones de Lista, como Lista<T>.Exists(T) entre otras, no he podido usarlas por darme errores que no comprendía todavía y no he sabido resolver.
	Sin embargo, me he buscado la vida para hacerlo de forma manual y poder sacar el ejercicio adelante. Consumirá más recursos, pero es funcional.
	Hacemos un foreach por cada fecha en la Lista y entramos a la funcionalidad solamente si el mes es distinto al del anterior vuelta para hacer esta operación una vez por mes. 
	Buscamos el último jueves del mes de cada fecha, y le sumamos uno.
	Buscamos dicha fecha en el listado fechas de CotizationDays. Si no existe, le sumamos uno. 
	Y así respectivamente hasta encontrar "El siguiente día cotizado después de cobrar el último jueves de cada mes".
	Al encontrarlo, guardamos esa fecha en un Nuevo listado de días de compra operativos. 
	Cuando tenemos la Lista con los días cotizados de compra, dividimos el dinero de la inversión inicial por la retención del broker y obtenemos la inversión final.
	Finalmente, calculamos las acciones que vamos comprando al precio de apertura de ese día, y vamos sumándolo al número final de acciones.
	Y para terminar, multiplicamos las acciones totales al precio de cierre del día de venta indicado.

	.UltimoDiaFichero(): Nos dice la fecha del último día que figura en un listado de días de cotización.