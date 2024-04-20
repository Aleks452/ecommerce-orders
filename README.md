# ecommerce-products
# Se deben ejecutar los scripts para la creación e inserción en la base de datos llamado ecommerce.sql
# En este estarás las siguiente tablas
  - categories
  - locations
  - orders
  - payments
  - products
  - shopping_car
  - status_car
  - taxes
  - trackings
  - users`
# El trigger se ejecutará cada vez que se haga una inserción en la tabla de orders, este cambiará el estado del shopping_car
  - update_shopping_car_status
# La versión de la base de datos es la 8.0 de MySQL
# Las configuraciones de base de datos deberán ser
  - puerto: 3306
  - ambiente: localhost
  - usuario: root
  - contraseña: Bogota#2O24
# Se debe instalar visual studio, se abre la solución y se ejecuta
# Se logrará visualizar cada uno de los endpoints en http://localhost:5151/swagger/index.html