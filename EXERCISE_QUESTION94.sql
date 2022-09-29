SELECT e.firstname, e.lastname, e.hire_date 
FROM employees e 
JOIN employees davies 
ON (davies.lastname = 'Jones') 
WHERE davies.hire_date < e.hire_date;