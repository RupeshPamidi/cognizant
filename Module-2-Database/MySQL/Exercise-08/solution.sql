-- Exercise 08: Sessions per Upcoming Event

SELECT e.event_id, e.title, COUNT(s.session_id) AS session_count
FROM Events e
LEFT JOIN Sessions s ON s.event_id = e.event_id
WHERE e.start_date >= CURDATE()
GROUP BY e.event_id, e.title
ORDER BY e.start_date;

