set search_path to "pmib6602";

CREATE TABLE IF NOT EXISTS pmib6602.users
(
    id uuid PRIMARY KEY,
    login char(255) NOT NULL UNIQUE ,
    password char(255) NOT NULL,
    role char(255) NOT NULL,
    canlogin boolean NOT NULL DEFAULT 'true'::boolean
);
INSERT INTO pmib6602.users (id, login, password, role) VALUES (pmib6602.get_uuid(),  @login, @password, @role);
SELECT id, login, password, role FROM pmib6602.users WHERE TRIM(login) = TRIM(@login);



CREATE TABLE IF NOT EXISTS pmib6602.search_default
(
    id uuid NOT NULL UNIQUE REFERENCES pmib6602.users(id),
    link text NOT NULL
);
ALTER TABLE pmib6602.search_default ADD CONSTRAINT unique_id_link_searchdefault UNIQUE (id, link);



CREATE TABLE IF NOT EXISTS pmib6602.user_history
(
    id uuid NOT NULL REFERENCES pmib6602.users(id),
    link text NOT NULL DEFAULT 'google.com'
);
ALTER TABLE pmib6602.user_history ADD CONSTRAINT unique_id_link_userhistory UNIQUE (id, link);
SELECT * FROM pmib6602.user_history;





