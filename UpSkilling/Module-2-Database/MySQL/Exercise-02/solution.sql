-- Exercise 02: Top Rated Events

SELECT e.event_id, e.title,
	   AVG(f.rating) AS avg_rating,
	   COUNT(f.feedback_id) AS feedback_count
FROM Events e
JOIN Feedback f ON f.event_id = e.event_id
GROUP BY e.event_id, e.title
HAVING COUNT(f.feedback_id) >= 10
ORDER BY avg_rating DESC;

