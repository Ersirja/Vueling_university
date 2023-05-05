# Ejercicio 5 Cinrel

En el reino de Cinrel, hay un gobierno estable por el actual monarca llamado I Tercero, este tiene 3 hijos I Quinto, I Septimo e I Noveno, que conviven con su abuelo Cenrelon.

Para establecer tratados con otros reinos, I Tercero debe ausentarse y decide establecer un plan de gobierno en el cual cada uno de sus hijos tomara el mando cada mes
que el permanezaca ausente.

Por desgracia el último mes el abuelo se levanta contra los nietos para reclamar el reinado, lo que provoca sus desestabilizacion.

Crear una aplicacion que simule el gobierno de cada uno de los hijos teniendo en cuenta que cada uno de ellos lo hara siguiendo los metodos de su padre pero de manera diferente 
y en la ultima iteracion ha de estar presente el abuelo que no comparte para nada los metodos del padre.






# EJERCICIO DE JAN REIG:


Voy a contar como he hecho el directorio:

# Este es el directorio

    - gobernantes
        - abuelo.cs
        - gobernante.cs
        - hijos.cs
        - rey.cs
    - reino_cinrel
        - reino_cinrel
    Program.cs


en la carpeta de gobernantes he puesto:
    - Gobernante.cs: tiene una clase publica base, de la cual todas parten hacia aqui que coge el nombre y luego se escupe hacia otras classes, tambien se coge la clase gobernar que esta en este archivo.
    - abuelo.cs: el nombre lo coge Gobernante.cs y el console writeline con la clase Gobernar
    - hijos.cs: el nombre lo coge Gobernante.cs y el console writeline con la clase Gobernar
    - rey.cs: console writeline con la clase Gobernar, aqui se ha hecho la clase para representar los hijos que luego se va a escupir a program.cs

en la carpeta reino_cinrel:
    - reino_cinrel: he puesto basicamente la classe que haria representacion de lo que seria el reino_cinrel. Crea las clases creadas previamente en la otra carpeta y los objetos si no lo estoy diciendo mal y los unes en la clase reinocinrel, como en program.cs insertare los nombres de los hijos y lo demas no, he hecho que Rey y abuelo sean de lectura, ademas que el inteligence me lo ha recomendado. Simulo el gobierno.
    
    
    
y en program.cs he puesto el nombre de los hijos del gobierno y lo he ejectuado.
