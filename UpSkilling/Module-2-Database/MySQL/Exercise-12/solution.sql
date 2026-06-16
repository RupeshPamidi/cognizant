-- Exercise 12: Event with Maximum Sessions

SELECT e.event_id, e.title, COUNT(s.session_id) AS session_count
FROM Events e
LEFT JOIN Sessions s ON s.event_id = e.event_id
GROUP BY e.event_id, e.title
HAVING session_count = (
	SELECT MAX(cnt) FROM (
		SELECT COUNT(session_id) AS cnt FROM Sessions GROUP BY event_id
	) AS counts
);

