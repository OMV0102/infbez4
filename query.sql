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





CREATE OR REPLACE FUNCTION pmib6602.get_uuid()
RETURNS uuid AS
$body$
DECLARE
 v_ts timestamptz DEFAULT clock_timestamp();
 v_ms double precision DEFAULT EXTRACT(SECOND FROM (v_ts));
 v_uuid varchar(32) DEFAULT '';
 v_objtype varchar(4) DEFAULT '0000';
 v_apptype varchar(2) DEFAULT '00';
 p_objtype integer DEFAULT 0;
 p_apptype integer DEFAULT 0;
BEGIN
p_objtype := (mod((random() * 100000 + 1)::integer, 65535))::integer;
p_apptype := (mod((random() * 1000 + 1)::integer, 255))::integer;
 -- Prepare Object type value
 IF (p_objtype > 0) THEN
 v_objtype := lpad(right(to_hex(p_objtype),4),4,'0');
 END IF;

-- Prepare Application type value
 IF (p_apptype > 0) THEN
 v_apptype := lpad(right(to_hex(p_apptype),2),2,'0');
 END IF;

-- Compile UUID in format TTTTTTTT-SSSS-SSAA-OOOO-RRRRRRRRRRRR
 ---- T - Timestamp segment (4 bytes)
 ---- S - Microseconds with .0000 precission
 ---- A - Application type segment (2 bytes)
 ---- O - Object type segment (4 bytes)
 ---- R - Random segment (4 bytes)
 v_uuid := v_uuid || to_hex(EXTRACT(EPOCH FROM v_ts)::integer)::text 
 || lpad(to_hex((trunc(v_ms * 1000000) - trunc(v_ms) * 1000000)::integer)::text,6,'0')
 || v_apptype
 || v_objtype
 || lpad(to_hex((random()*65535)::bigint),4,'0')
 || lpad(to_hex((random()*65535)::bigint),4,'0')
 || lpad(to_hex((random()*65535)::bigint),4,'0');
 RETURN v_uuid::uuid;
END;
$body$
LANGUAGE 'plpgsql'
VOLATILE
CALLED ON NULL INPUT
SECURITY INVOKER
COST 100;



