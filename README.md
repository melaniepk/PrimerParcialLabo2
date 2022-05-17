Explicación del proyecto:
El proyecto de gestión del bar Les UTN comienza con un formulario por el cual se pueden loguear tanto los empleados como los dueños del local.
Se muestran en este dos botones que sirven para rellenar los textBox con datos seguros para acceder al local tanto siendo empleado como siendo dueño.
Al abrirse el formulario de Administración local se pueden ver tres botones a la izquierda, los cuales van a estar habilitados o no según el rol que corresponda al
usuario logueado. En caso de loguearse un dueño, los botones de “inventario”, “personal” y “salir” estarán habilitados; en caso contrario solo estará habilitado el
botón de “salir”. También cambiará el color de fondo del formulario según quien se loguee.
a la derecha aparecen los botones correspondientes a las mesas y los lugares en la barra, todos en verde ya que el bar se encuentra vacío. Acá me encontré con un
problema puesto que no consigo manejar bien el color de las mesas.
Probé un montón de cosas pero nada funcionó así que solamente dejé que cada vez que se haga click en la mesa, esta cambie de color. Lo que hace que en definitiva no se
pueda saber si está ocupada o no y esto tenga que ser dispuesto a mano por el administrador, haciendo click. Al enfrentarme a este problema y fallar en repetidas
ocasiones tratando de resolverlo, decidí que el click en la mesa sirviera para abrir el formulario de nueva venta y la venta se hiciera en el momento.  Tampoco logré
acumular los pedidos de una mesa para cobrarlos después. Al abrir el formulario nueva venta se muestran dos comboboxes con las bebidas y las comidas, y otras dos con
los tamaños de cada una. Del lado derecho en un richtextBox se muestra el detalle del producto seleccionado y agregado y en el Datagridview de abajo se muestra el
pedido completo.
Al hacer click en cerrar venta, se abre un nuevo formulario para pagar, que permite seleccionar medios de pago y aplicar recargos. Apliqué un recargo del 10% por uso
de estacionamiento pero escribiendo esto me doy cuenta que no es justo.
Volviendo a las otras funciones, el dueño puede ver el inventario y hacerle modificaciones haciendo click en su botón en el formulario de administración del local,
pero no conseguí que esos cambios se vieran reflejados en los productos a la hora de venderlos.
En el botón de personal, el dueño puede ver los datos del personal registrado. 

Implementación de temas:
•	 Herencia 
Comida y Bebida heredan de Menú
•	 Sobrecarga de constructores y
métodos
Constructores en la clase usuario y la clase mesa.
•	Propiedades
En la clase usuario, bebida y comida implemento propiedades
•	 Colecciones (al menos 2
colecciones diferentes)
Utilizo las colecciones array, list y dictionary
•	Enumerados
Utilicé un enumerado para los tamaños
•	Formularios modal.
Utilizado en los formularios menú nueva venta y cerrar venta
•	Clases estáticas
La clase local
•	Polimorfismo (clases abstractas,
métodos abstractos, métodos
virtuales
La clase menú es abstracta, en ella se declaran métodos abstractos implementados en bebida y comida, así como el virtual mostrar producto.
