-- Exercise 05: Most Active Cities

SELECT u.city, COUNT(DISTINCT r.user_id) AS distinct_registrations
FROM Registrations r
JOIN Users u ON u.user_id = r.user_id
GROUP BY u.city
ORDER BY distinct_registrations DESC
LIMIT 5;

