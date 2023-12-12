# BackEnd-SideProject
Proyecto Fullstack para Campuslands en 10 Dias

### Diagrama de la base de datos
![](./drawSQL-laostiavital.png)


---

### Migraciones
Crear
```Terminal
dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./API/ --output-dir ./Data/Migrations/
```

Actualizar
```Terminal
dotnet ef database update --project ./Persistencia/ --startup-project ./API/  
```
---

### Consultas

 - Consulta #1 - Obtener perfiles por especialidad
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorEspecialidad/{Id}
    ```

 - Consulta #2 - Obtener perfiles por país
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorPais/{Id}
    ```

 - Consulta #3 - Obtener perfiles por departamento
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorDepartamento/{Id}
    ```

 - Consulta #4 - Obtener perfiles por ciudad
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorCiudad/{Id}
    ```

 - Consulta #5 - Obtener perfiles por Nivel de Ingles
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorNivelIngles/{Id}
    ```

 - Consulta #6 - Obtener perfiles por Seniority
    ```Terminal
    http://localhost:9000/Api/Perfil/perfilesPorSeniority/{Id}
    ```


---


