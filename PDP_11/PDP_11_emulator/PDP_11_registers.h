#include "PDP_11_types.h"

typedef struct _PDP_11_registers {
	short R0;
	short R1;
	short R2;
	short R3;
	short R4;
	short R5;
	short SP;
	short PC;

	short MW;

} PDP_11_registers;

status_t PDP_11_registers_init(PDP_11_registers* registers);
status_t PDP_11_registers_read_register(char* name, PDP_11_registers* registers, short* buffer);
status_t PDP_11_registers_write_register(char* name, PDP_11_registers* registers, short buffer);
status_t PDP_11_registers_read_flag(char* name, PDP_11_registers* registers, char* value);			//@TODO: maybe improve it (about flag value)
status_t PDP_11_registers_write_flag(char* name, PDP_11_registers* registers, char value);			//