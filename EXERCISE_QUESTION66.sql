SELECT JOB_ID , MAX(SALARY) AS 'MAXIMUM SALARY' FROM EMPLOYEES
GROUP BY JOB_ID 
HAVING MAX(SALARY) >=4000;