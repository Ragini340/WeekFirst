SELECT b.FIRSTNAME,b.LASTNAME FROM EMPLOYEES b 
WHERE NOT EXISTS (SELECT 'X' FROM EMPLOYEES a WHERE a.MANAGER_ID = b.EMPLOYEE_ID);