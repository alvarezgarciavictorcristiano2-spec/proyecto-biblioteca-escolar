# Documento de Diseño Preliminar - Biblioteca Escolar

## Comparación de Estructuras Candidatas

1. **Arreglo Escalonado (Jagged Array - int[][]):**
   - **Pros:** Permite filas de diferente longitud, adaptándose perfectamente a títulos con distinta cantidad de ejemplares sin desperdiciar celdas vacías[cite: 2].
   - **Contras:** Su manipulación y lógica de búsqueda resultan más complejas.

2. **Lista de arreglos (List<int[]>):**
   - **Pros:** Aporta dinamismo general.
   - **Contras:** Sigue dependiendo de arreglos internos primitivos, dificultando asociar atributos como ISBN o préstamos.

3. **Lista de Objetos (List<Título> / List<Libro>):**
   - **Pros:** Es la opción más limpia y orientada a objetos. Encapsula perfectamente los atributos del libro y gestiona la cantidad irregular de ejemplares de forma robusta[cite: 2].
   - **Contras:** Requiere definir una clase dedicada.

## Conclusión
Se selecciona la estructura basada en objetos (`List<Libro>`) por su claridad, eficiencia y facilidad para implementar las búsquedas y ordenamientos requeridos[cite: 2].