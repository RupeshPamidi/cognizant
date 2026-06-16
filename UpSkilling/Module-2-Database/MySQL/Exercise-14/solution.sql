-- Exercise 14: Most Registered Events

SELECT e.event_id, e.title, COUNT(r.registration_id) AS registrations
FROM Events e
LEFT JOIN Registrations r ON r.event_id = e.event_id
GROUP BY e.event_id, e.title
ORDER BY registrations DESC
LIMIT 3;

