SELECT city,
       postalcode,
       modifieddate
FROM   person.address
WHERE  city = 'ALBANY'
        OR postalcode = '97321'
        OR city = 'TORONTO'
ORDER  BY city 

SELECT CITY,PostalCode,ModifiedDate 
FROM Person.Address 
WHERE CITY = 'ALBANY'
OR CITY = 'TORONTO'
OR CITY = 'WATERLOO'
OR CITY = 'PARIS'
ORDER BY CITY


SELECT CITY,PostalCode,ModifiedDate 
FROM Person.Address 
WHERE CITY IN ('ALBANY','TORONTO','WATERLOO','PARIS')
ORDER BY CITY

