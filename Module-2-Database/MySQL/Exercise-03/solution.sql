-- Exercise 03: Inactive Users

SELECT u.user_id, u.full_name, u.email, MAX(r.registration_date) AS last_registration_date
FROM Users u
LEFT JOIN Registrations r ON r.user_id = u.user_id
GROUP BY u.user_id, u.full_name, u.email
HAVING (MAX(r.registration_date) IS NULL) OR (MAX(r.registration_date) < CURDATE() - INTERVAL 90 DAY);

