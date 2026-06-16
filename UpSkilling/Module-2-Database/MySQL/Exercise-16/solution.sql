-- Exercise 16: Unregistered Active Users

SELECT u.user_id, u.full_name, u.email, u.registration_date
FROM Users u
LEFT JOIN Registrations r ON r.user_id = u.user_id
WHERE u.registration_date >= CURDATE() - INTERVAL 30 DAY
GROUP BY u.user_id, u.full_name, u.email, u.registration_date
HAVING COUNT(r.registration_id) = 0;

