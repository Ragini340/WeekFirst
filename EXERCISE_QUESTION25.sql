SELECT EMPLOYEE_ID , LASTNAME, SALARY
FROM EMPLOYEES
WHERE DEPARTMENT_ID IN (SELECT DEPARTMENT_ID FROM EMPLOYEES WHERE LASTNAME LIKE '%u%')
AND SALARY > (SELECT AVG(SALARY) FROM EMPLOYEES)
