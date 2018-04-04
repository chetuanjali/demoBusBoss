<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="StudentPatrolTest.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <p>Welcome Home Page </p>
        </div>
    </form>
     <script type="text/javascript" src="api.js"></script>
    <script type="text/javascript">
        geotab.addin.Home = function(api, state) {
            var user;
           
            
           var initializeUser = function () {
                // Initialize the map container
                user = document.getElementById("myframe").on("load", function () {
                var getUser = function (finishedCallback) {
                api.call("Get", {
                    typeName: "User",
                    search: {
                        fromDate: new Date()
                    }
                }, function (results) {
                    user = results.user(function (user) {
                        return {
                            name: user.name,
                            id: user.id
                        };
                    });
                    finishedCallback();
                }, function (errorString) {
                    alert(errorString);
                });
            };
         })

        
       
             return {
                /*
                 * Page lifecycle method: initialize is called once when the addin first starts
                 * Use this function to initialize the addin's state such as default values or
                 * make API requests (Geotab or external) to ensure interface is ready for the user.
                 */
                initialize: function(api, state, callback) {
                    // Initialize the map
                    initializeUser();
                    // Must be called to let the app know that we've initialized the addon
                    getUser(callback);
                },
             
           };
</body>
</html>
