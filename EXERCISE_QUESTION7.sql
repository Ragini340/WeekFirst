SELECT W.LASTNAME "Employee", W.EMPLOYEE_ID "EMP#",
M.LASTNAME "Manager", M.EMPLOYEE_ID "Mgr#"
FROM EMPLOYEES W
LEFT OUTER JOIN EMPLOYEES M
ON (W.MANAGER_ID = M.EMPLOYEE_ID);