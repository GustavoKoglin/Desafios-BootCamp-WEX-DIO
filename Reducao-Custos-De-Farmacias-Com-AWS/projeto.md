# Relatório de Implementação de Serviços AWS para Redução de Custos  
**Data:** 30/05/2025  
**Empresa:** Abstergo Industries  
**Responsável:** Gustavo Borges Koglin

---

## Introdução  
Este relatório descreve a implementação de serviços AWS na [Nome da Empresa Farmacêutica], com o objetivo de reduzir custos operacionais imediatos. Foram selecionados três serviços AWS que oferecem eficiência financeira e otimização de recursos.  

---

## Descrição do Projeto  
O projeto foi dividido em três etapas, cada uma focada em um serviço AWS específico:  

## Etapa 1: AWS Cost Explorer
- **Foco da ferramenta:**  
  Análise e visualização de custos em tempo real com inteligência de otimização
- **Caso de uso:**  
  Identificar e eliminar recursos ociosos (instâncias EC2 com utilização <15%, volumes EBS não utilizados)
- **Economia esperada:**  
  **15-30%** em custos mensais através de:
  - Terminação de instâncias subutilizadas
  - Redimensionamento de recursos superdimensionados
  - Otimização de reservas não utilizadas

## Etapa 2: AWS Reserved Instances (RIs)
- **Foco da ferramenta:**  
  Redução de custos com compromisso de uso antecipado
- **Caso de uso:**  
  Compra estratégica de RIs para cargas de trabalho estáveis (bancos de dados RDS, servidores de aplicação)
- **Economia esperada:**  
  **Até 75%** comparado ao modelo On-Demand:
  - Standard RIs: 40-50% de desconto
  - Convertible RIs: 30-40% com flexibilidade
  - Pagamento total antecipado: máximo desconto

## Etapa 3: AWS Lambda
- **Foco da ferramenta:**  
  Computação serverless com cobrança por uso
- **Caso de uso:**  
  Automação de processos farmacêuticos:
  - Validação de lotes (trigger por upload no S3)
  - Processamento de dados clínicos (eventos schedule)
- **Economia esperada:**  
  **50-70%** versus EC2 tradicional:
  - Zero custo por ociosidade
  - Escala automática granular
  - Cobrança por milissegundo de execução

## Etapa 4: S3 Intelligent-Tiering
- **Foco da ferramenta:**  
  Otimização automática de custos de armazenamento
- **Caso de uso:**  
  Gestão inteligente de:
  - Registros de ensaios clínicos
  - Documentação regulatória
  - Logs de produção
- **Economia esperada:**  
  **Até 40%** versus S3 Standard:
  - Transição automática entre tiers
  - Sem taxas de recuperação
  - Monitoramento contínuo de padrões de acesso

---

## Conclusão  
A implementação desses serviços AWS na [Nome da Empresa Farmacêutica] resultou em uma **redução significativa de custos**, maior eficiência operacional e escalabilidade. Recomenda-se:  
- Monitoramento contínuo com o **AWS Cost Explorer**.  
- Expansão do uso de **RIs** para outros serviços.  
- Adoção de **AWS Lambda** em mais processos automatizáveis.  

**Assinatura do Responsável:**  
   *Gustavo Borges Koglin*