CREATE PROCEDURE ObtenerUltimos10MayoresDe21
AS
BEGIN
    SELECT TOP 10
        id,
        Nombre,
        Apellido,
        FechaNacimiento,
        Telefono
    FROM
        personas
    WHERE
        DATEDIFF(YEAR, FechaNacimiento, GETDATE()) > 21
    ORDER BY
        Nombre;
END

EXEC ObtenerUltimos10MayoresDe21