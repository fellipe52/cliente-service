#  Cliente API

API RESTful para criação de novos clientes.

---


# Pré-requisitos
- [. NET 8 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
- [Docker](https://www.docker.com/get-started/)
- [Azure Cloud](https://portal.azure.com/)
  - Grupo de Recursos
  - Container Registry
  - AKS
  - Azure Cosmos DB for PostgreSQL Cluster

#  Deploy
    Criar perfil Git:
    
    az ad sp create-for-rbac --name "my-github-actions" --role contributor --scopes /subscriptions/{sua-subscription}/resourceGroups/veiculo --query "{client_id: appId, client_secret: password, tenant_id: tenant}"

    Variáveis Git:
    
    AZURE_CREDENTIALS

    Deployment:
    src/deploy -> Contém arquivos deployment, service e secrets

    WorkFlows:
    .github/workflows -> Contém arquivos build .net e execução dos arquivos de deploy no azure cloud.