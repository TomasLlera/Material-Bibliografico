# 📚 Material Bibliográfico

## 🧠 Descripción del proyecto

Este proyecto en C# simula un sistema de gestión de material bibliográfico para una biblioteca. Permite al usuario agregar y eliminar distintos tipos de materiales como libros físicos, ebooks y revistas, almacenándolos en listas y mostrando su información en consola.

---

## 🧩 Estructura del programa

El sistema está compuesto por las siguientes clases:

- `Material_Bibliografico`: Clase base abstracta que contiene los atributos comunes (título y año).
- `Libro`: Hereda de `Material_Bibliografico` y añade el número de páginas y el autor.
- `Ebook`: Hereda de `Material_Bibliografico` y añade el peso en megabytes y el autor.
- `Revista`: Hereda de `Material_Bibliografico` y añade el volumen y el autor.
- `Autor`: Clase que representa al autor, con su nombre.
- `Menu`: Clase que contiene el menú principal y coordina las acciones de agregar o eliminar materiales.

---

## 🔧 Funcionalidades

- Agregar libro físico 📘  
- Agregar ebook 💾  
- Agregar revista 📰  
- Eliminar cualquier tipo de material  
- Mostrar la información del material agregado  

Cada tipo de material se guarda en su respectiva lista (`libro`, `ebook`, `revista`), y su información puede visualizarse en consola con detalles como título, año, peso/páginas/volumen y autor.

---
## 🛠️ Posibles mejoras futuras
- Guardar los datos en archivos para que no se pierdan al cerrar el programa.

- Agregar edición de materiales ya agregados

- Validaciones más robustas al ingresar datos.
