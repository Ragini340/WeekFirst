SELECT EMPLOYEE_ID, LASTNAME 
FROM EMPLOYEES
WHERE DEPARTMENT_ID IN (SELECT DEPARTMENT_ID FROM EMPLOYEES WHERE LASTNAME LIKE '%u%');