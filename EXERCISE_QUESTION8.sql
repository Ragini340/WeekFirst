SELECT E.DEPARTMENT_ID DEPARTMENT, E.LASTNAME employee,
C.LASTNAME colleague
FROM EMPLOYEES E JOIN EMPLOYEES C
ON (E.DEPARTMENT_ID = C.DEPARTMENT_ID)
WHERE E.EMPLOYEE_ID <> C.EMPLOYEE_ID
ORDER BY E.DEPARTMENT_ID, E. LASTNAME, C.LASTNAME;