-- SQL para Buscar Clientes do Estado de São Paulo (SP) com Telefones

SELECT
    c.cliente_id AS Código,
    c.razao_social AS 'Razão Social',
    c.email AS E-mail,
    t.numero AS Telefone,
    t.tipo_telefone AS 'Tipo de Telefone'
FROM
    Cliente c
    INNER JOIN Telefone t ON c.cliente_id = t.cliente_id
    INNER JOIN Estado e ON c.estado_id = e.estado_id
WHERE
    e.sigla_estado = 'SP';
