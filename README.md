# Programaci-n-III
Estructura de datos 
Se generaron 10 millones de números aleatorios almacenados en un archivo de texto.
Luego se cargaron en tres estructuras de datos distintas: lista, árbol binario y tabla hash.
Se realizaron 1,000 búsquedas aleatorias y se midió el tiempo promedio de búsqueda.
Los resultados muestran que la tabla hash es la más eficiente, mientras que la lista es la más lenta.

Los valores mostrados como 0.00 ms no indican tiempo nulo, sino que el tiempo promedio por búsqueda es extremadamente pequeño y se redondea a cero debido al formato de salida. Al aumentar la precisión o el número de búsquedas, se observan diferencias reales entre las estructuras.

| Estructura | Tu resultado |    enunciado      |
| ---------- | ------------ | ----------------- |
| Lista      | 2.01 ms      | 350 ms            |
| Árbol      | ~0 ms        | 4.2 ms            |
| Hash       | ~0 ms        | 0.08 ms           |

Si el numero de búsquedas se aumentan por el usurio para verificar que tan eficiente y tardada es la busqueda en nuestra tabla de comparación y reaccion de segundos podemos verificar, ya que en 1,000 busquedas el tiempo está entre 20 a 40 segundos  mientas que si por ejemplo coloco una busqueda de 100,000 busquedas el tiempo puede estar entre 1 minuto o 1:45 minutos esto va a depender mucho de la computadora y que requisitos tenga.

FILA 1 — Lista enlazada (O(n))
Recorre elemento por elemento
No está ordenada
Si el número está al final → revisa todo

FILA 2 — Árbol binario (O(log n))
Árbol binario balanceado
Divide el problema a la mitad en cada paso

FILA 3 — Tabla Hash (O(1))
Usa función hash
Va directo a la posición
No recorre datos
