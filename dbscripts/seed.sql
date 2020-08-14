\connect svc

CREATE TABLE settings
(
    id uuid NOT NULL,
    category integer NOT NULL,
    name character varying NOT NULL,
    value character varying ,
    type_id integer NOT NULL,
    unique (id, category, name)
);

ALTER TABLE settings OWNER TO postgres;

Insert into settings(id, category, name, value, type_id) values( '775bd791-85be-40e6-bfad-35d98559ce9c', 1, 'Setting1', 'Value1', 1);
Insert into settings(id, category, name, value, type_id) values( '775bd791-85be-40e6-bfad-35d98559ce9c', 1, 'Setting2', '10', 2);
Insert into settings(id, category, name, value, type_id) values( '775bd791-85be-40e6-bfad-35d98559ce9c', 2, 'Setting3', 'true', 3);
Insert into settings(id, category, name, value, type_id) values( '775bd791-85be-40e6-bfad-35d98559ce9c', 2, 'Setting4', '2020-06-03T00:00:00', 4);
Insert into settings(id, category, name, value, type_id) values( '775bd791-85be-40e6-bfad-35d98559ce9c', 2, 'Setting5', '{name1:"value",name2:2,name3:true,name4:null}', 5);