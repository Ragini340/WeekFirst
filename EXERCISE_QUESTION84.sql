SELECT DISTINCT SALARY FROM EMPLOYEES e1 WHERE 4 = (SELECT COUNT(DISTINCT SALARY) 
FROM EMPLOYEES e2 WHERE e2.SALARY<= e1.SALARY);