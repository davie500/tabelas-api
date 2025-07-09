const swaggerJsdoc = require("swagger-jsdoc");

const options = {
  definition: {
    openapi: "3.0.0",
    info: {
      title: "Tech Store API",
      version: "1.0.0",
      description: "Documentação da API da Tech Store",
    },
    servers: [
      {
        url: "http://localhost:3000",
      },
    ],
  },
  apis: ["./src/routes/*.js"], // Caminho para as anotações das rotas
};

const swaggerSpec = swaggerJsdoc(options);
module.exports = swaggerSpec;
