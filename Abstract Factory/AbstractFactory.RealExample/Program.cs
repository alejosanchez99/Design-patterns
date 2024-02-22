

using AbstractFactory.Example2;
using AbstractFactory.Example2.Factories;

IPaymentGatewayFactory payPalPaymentGatewayFactory = new PayPalGatewayFactory();
PaymentService paymentServicePayPal = new PaymentService(payPalPaymentGatewayFactory);

decimal amount = 100.00m;
paymentServicePayPal.ProcessPayment(amount);

IPaymentGatewayFactory stripePaymentGatewayFactory = new StripeGatewayFactory();
PaymentService stripePaymentService = new PaymentService(stripePaymentGatewayFactory);

stripePaymentService.ProcessPayment(amount);
