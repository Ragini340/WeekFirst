SELECT FIRSTNAME, LASTNAME, SALARY FROM EMPLOYEES 
WHERE SALARY > (SELECT SALARY FROM EMPLOYEES WHERE LASTNAME = 'Bell') ORDER BY FIRSTNAME;