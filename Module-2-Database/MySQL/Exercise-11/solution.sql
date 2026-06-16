-- Exercise 11: Daily New User Count

SELECT registration_date AS day, COUNT(*) AS new_users
FROM Users
WHERE registration_date >= CURDATE() - INTERVAL 6 DAY
GROUP BY registration_date
ORDER BY registration_date DESC;

