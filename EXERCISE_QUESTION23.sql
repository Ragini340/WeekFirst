SELECT LASTNAME, SALARY
FROM EMPLOYEES
WHERE MANAGER_ID IN (SELECT EMPLOYEE_ID FROM EMPLOYEES WHERE LASTNAME='King');