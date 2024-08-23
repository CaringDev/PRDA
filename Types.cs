using System.ComponentModel.DataAnnotations;

namespace PRDA;

// "NormalNoOpenApi": {
//   "required": ["payload"],
//   "type": "object",
//   "properties": {
//     "payload": { "type": "string" }
//   }
// }
public record NormalNoOpenApi([StringLength(2)] string Payload);

// "Good": {
//   "type": "object",
//   "properties": {
//     "payload": {
//       "maxLength": 2,
//       "minLength": 0,
//       "type": "string"
//     }
//   }
// }
public record Good
{
    [StringLength(2)] public required string Payload { get; init; }
}

// same as NormalNoOpenApi
public record NoOpenApi([param: StringLength(2)] string Payload);

// same as Good
public record NoGood([property: StringLength(2)][param: StringLength(2)] string Payload);

// same as Good
public record NoValidation([property: StringLength(2)] string Payload);