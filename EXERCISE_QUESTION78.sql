SELECT FIRSTNAME,LASTNAME, JOB_ID, SALARY FROM EMPLOYEES 
WHERE SALARY > 
ALL (SELECT SALARY FROM EMPLOYEES WHERE JOB_ID = 'SH_CLERK') ORDER BY SALARY;