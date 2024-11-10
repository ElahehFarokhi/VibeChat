import {
  Component,
  EventEmitter,
  OnDestroy,
  OnInit,
  Output,
} from '@angular/core';
import { PrivateChatComponent } from '../private-chat/private-chat.component';
import { ChatService } from '../services/chat.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MessagesComponent } from '../messages/messages.component';
import { ChatInputComponent } from '../chat-input/chat-input.component';
import { NgClass, NgFor } from '@angular/common';

@Component({
  selector: 'app-chat',
  standalone: true,
  imports: [MessagesComponent,ChatInputComponent,NgClass, NgFor],
  templateUrl: './chat.component.html',
  styleUrl: './chat.component.css',
})
export class ChatComponent implements OnInit, OnDestroy {
  @Output() closeChatEmitter = new EventEmitter();

  constructor(
    public chatService: ChatService,
    private modalService: NgbModal
  ) {}
  ngOnInit(): void {
    this.chatService.createChatConnection();
  }

  ngOnDestroy(): void {
    this.chatService.stopChatConnection();
  }

  backToHome() {
    this.closeChatEmitter.emit();
  }

  sendMessage(content: string) {
    this.chatService.sendMessage(content);
  }

  openPrivateChat(toUser: string) {
    const modalRef = this.modalService.open(PrivateChatComponent);
    modalRef.componentInstance.toUser = toUser;
  }
}