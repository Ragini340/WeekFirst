SELECT FIRSTNAME, LASTNAME
FROM EMPLOYEES
WHERE DEPARTMENT_ID
IN (SELECT DEPARTMENT_ID FROM DEPARTMENTS WHERE DEPARTMENT_NAME ='IT');