import base64

originalString = b"Hello World!"
print("OriginalString:" + str(originalString))

encodedString = base64.b64encode(originalString)
print("EncodedString:" + str(encodedString))

decodedString = base64.b64decode(encodedString);
print("Decoded String:" + str(decodedString))