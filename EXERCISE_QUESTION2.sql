SELECT DISTINCT JOB_ID, LOCATION_ID
FROM EMPLOYEES, DEPARTMENTS
WHERE EMPLOYEES.DEPARTMENT_ID = DEPARTMENTS.DEPARTMENT_ID
AND EMPLOYEES.DEPARTMENT_ID = 30;