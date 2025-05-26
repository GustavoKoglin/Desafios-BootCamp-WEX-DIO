Feature: CT02-BDD-CADASTRO-CAMPOS-OBRIGATORIOS
    @TestCaseKey=GK-T3
    Scenario: CT02-BDD-CADASTRO-CAMPOS-OBRIGATORIOS
        
        # language: en
        #Feature: User Authentication API
        #  As a system
        #  I need to validate credentials via API
        #  To ensure secure access to resources
        
          #1: Login válido (Valid login scenario)
          #Scenario: Successful login with correct credentials
            Given the API endpoint "/login" is available
            And the user provides valid credentials:
              | username | password |
              | testUser | testPass |
            When the login API is called with a POST request
            Then the response status code should be 200
            And the response body should contain a JWT token
        
          #2: Credencial inválida (Invalid credential scenario)  
          #Scenario: Login attempt with wrong password
            Given the API endpoint "/login" is available
            And the user provides invalid credentials:
              | username | password  |
              | testUser | wrongPass |
            When the login API is called with a POST request
            Then the response status code should be 401
            And the response should contain "Invalid credentials"
        
          #3: Campo obrigatório faltando (Missing required field scenario)
          #Scenario: Login attempt without password
            Given the API endpoint "/login" is available
            And the user provides incomplete credentials:
              | username | password |
              | testUser |          |
            When the login API is called with a POST request
            Then the response status code should be 400
            And the response should contain "Password is required"